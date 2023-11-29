(defun C:descrip (/ x1 x2 x3)
  (vl-load-com)

  (foreach kab '("EL_text"
"0"
		)
    (vla-put-description
      (vlax-ename->vla-object (tblobjname "LAYER" kab))
      "Резервуар грязной воды"
    )
  )

)