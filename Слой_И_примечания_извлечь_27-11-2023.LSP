(defun c:MKSxPrintLayerDesc(/ lyrCol lyr lyrDesc doc)
  (setq doc (vla-get-activeDocument (vlax-get-acad-object)) ;;get active drawing
 lyrCol (vla-get-layers doc)  ;;get layer collection
  )
  (princ "\n\n")
  (vlax-for lyr lyrCol  ;;iterate through each layer object in the collection
	(setq lyrDesc (vla-get-description lyr)  ;;get the layer description of the current layer object
   lyrName (vla-get-name lyr)  ;;get the layer name of the current layer object
	)
	(princ (strcat lyrName ": " lyrDesc "\n"))  ;;print the layer name and layer description
  )
  (princ "\n\n ")
  (princ)
)