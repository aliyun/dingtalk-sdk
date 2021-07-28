<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetFileUploadInfoRequest extends Model
{
    /**
     * @description 业务标识
     *
     * @var string
     */
    public $bizCode;

    /**
     * @description 文件名称
     *
     * @var string
     */
    public $fileName;

    /**
     * @description 文件大小（单位：字节）
     *
     * @var int
     */
    public $fileSize;

    /**
     * @description 文件MD5摘要
     *
     * @var string
     */
    public $md5;

    /**
     * @description 操作人员工标识，为空时默认以企业管理员身份进行操作
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'bizCode'  => 'bizCode',
        'fileName' => 'fileName',
        'fileSize' => 'fileSize',
        'md5'      => 'md5',
        'opUserId' => 'opUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->fileName) {
            $res['fileName'] = $this->fileName;
        }
        if (null !== $this->fileSize) {
            $res['fileSize'] = $this->fileSize;
        }
        if (null !== $this->md5) {
            $res['md5'] = $this->md5;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFileUploadInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['fileName'])) {
            $model->fileName = $map['fileName'];
        }
        if (isset($map['fileSize'])) {
            $model->fileSize = $map['fileSize'];
        }
        if (isset($map['md5'])) {
            $model->md5 = $map['md5'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
