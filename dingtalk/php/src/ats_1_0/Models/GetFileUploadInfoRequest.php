<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetFileUploadInfoRequest extends Model
{
    /**
     * @example ddats
     *
     * @var string
     */
    public $bizCode;

    /**
     * @example 张三的简历
     *
     * @var string
     */
    public $fileName;

    /**
     * @example 1024
     *
     * @var int
     */
    public $fileSize;

    /**
     * @example xxx
     *
     * @var string
     */
    public $md5;

    /**
     * @example manager5875
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
