USE `cinevision`;

INSERT INTO `tbl_modulos` VALUES
('1000', 'SEGURIDAD', 'Seguridad', 1),
('2000', 'CINEVISION', 'cinevision', 1);

-- -----APLICACIONES
INSERT INTO `tbl_aplicaciones` VALUES
('1000', 'MDI SEGURIDAD', 'PARA SEGURIDAD', '1'),
('1001', 'Mant. Usuario', 'PARA SEGURIDAD', '1'),
('1002', 'Mant. Aplicación', 'PARA SEGURIDAD', '1'),
('1003', 'Mant. Modulo', 'PARA SEGURIDAD', '1'),
('1004', 'Mant. Perfil', 'PARA SEGURIDAD', '1'),
('1101', 'Asign. Modulo Aplicacion', 'PARA SEGURIDAD', '1'),
('1102', 'Asign. Aplicacion Perfil', 'PARA SEGURIDAD', '1'),
('1103', 'Asign. Perfil Usuario', 'PARA SEGURIDAD', '1'),
('1201', 'Pcs. Cambio Contraseña', 'PARA SEGURIDAD', '1'),
('1301', 'Pcs. BITACORA', 'PARA SEGURIDAD', '1'),
('1998', 'LOGIN', 'PARA SEGURIDAD', '1'),
('1999', 'CERRAR SESIÓN', 'PARA SEGURIDAD', '1'),
('2000', 'MDI Universidad', 'PARA UNIVERSIDAD', '1'),
('2001', 'Mant. Alumno', 'PARA UNIVERSIDAD', '1'),
('2002', 'Mant. Profesor', 'PARA UNIVERSIDAD', '1'),
('2003', 'Mant. Aula', 'PARA UNIVERSIDAD', '1'),
('2004', 'Mant. Sede', 'PARA UNIVERSIDAD', '1'),
('2100', 'Prc. Registro Nota', 'PARA UNIVERSIDAD', '1'),
('2101', 'Prc. Administracion', 'PARA UNIVERSIDAD', '1'),
('2102', 'Prc. Seccion', 'PARA UNIVERSIDAD', '1'),
('2103', 'Prc. Sede', 'PARA UNIVERSIDAD', '1'),
('2104', 'Prc. asignacioncursosalumnos', 'PARA UNIVERSIDAD', '1'),
('2105', 'Prc. asignacioncursosprofesor', 'PARA UNIVERSIDAD', '1');

-- -----USUARIOS
INSERT INTO `tbl_usuarios` VALUES
('1', 'admin', 'admin', 'admin', 'HO0aGo4nM94=', 'esduardo@gmail.com', '2022-07-02 21:00:48', '1', 'COLOR FAVORITO', 'HO0aGo4nM94=');

-- -----PERFILES
INSERT INTO `tbl_perfiles` VALUES
('1', 'ADMINISTRADOR', 'contiene todos los permisos del programa', 1),
('2', 'UNIVERSIDAD', 'contiene todos los permisos de universidad', 1);

-- -----ASIGNACIÓNES MODULO A APLICACION
INSERT INTO `tbl_asignacionmoduloaplicacion` VALUES
('1000', '1000'),
('1000', '1001'),
('1000', '1002'),
('1000', '1003'),
('1000', '1004'),
('1000', '1102'),
('1000', '1103'),
('1000', '1201'),
('1000', '1301'),
('2000', '2000'),
('2000', '2001'),
('2000', '2002'),
('2000', '2003'),
('2000', '2004'),
('2000', '2100'),
('2000', '2101'),
('2000', '2102'),
('2000', '2103'),
('2000', '2104'),
('2000', '2105');

-- -----PERMISOS DE APLICACIONES A PERFILES
INSERT INTO `tbl_permisosAplicacionPerfil` VALUES
('1', '1000', '1', '1', '1', '1', '1'),
('1', '1001', '1', '1', '1', '1', '1'),
('1', '1002', '1', '1', '1', '1', '1'),
('1', '1003', '1', '1', '1', '1', '1'),
('1', '1004', '1', '1', '1', '1', '1'),
('1', '1101', '1', '1', '1', '1', '1'),
('1', '1102', '1', '1', '1', '1', '1'),
('1', '1103', '1', '1', '1', '1', '1'),
('1', '1201', '1', '1', '1', '1', '1'),
('1', '1301', '1', '1', '1', '1', '1'),
('1', '2000', '1', '1', '1', '1', '1'),
('1', '2001', '1', '1', '1', '1', '1'),
('1', '2002', '1', '1', '1', '1', '1'),
('1', '2003', '1', '1', '1', '1', '1'),
('1', '2004', '1', '1', '1', '1', '1'),
('1', '2100', '1', '1', '1', '1', '1'),
('1', '2101', '1', '1', '1', '1', '1'),
('1', '2102', '1', '1', '1', '1', '1'),
('1', '2103', '1', '1', '1', '1', '1'),
('1', '2104', '1', '1', '1', '1', '1'),
('1', '2105', '1', '1', '1', '1', '1');

-- -----ASIGNACIÓN DE PERFIL A USUARIO
INSERT INTO `tbl_asignacionesPerfilsUsuario` VALUES
('1', '1'); 