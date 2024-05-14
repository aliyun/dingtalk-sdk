<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddFileRequest extends Model
{
    /**
     * @example ddats
     *
     * @var string
     */
    public $bizCode;

    /**
     * @description This parameter is required.
     *
     * @example 张三的简历
     *
     * @var string
     */
    public $fileName;

    /**
     * @description This parameter is required.
     *
     * @example xxx
     *
     * @var string
     */
    public $mediaId;

    /**
     * @example manager5875
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'bizCode'  => 'bizCode',
        'fileName' => 'fileName',
        'mediaId'  => 'mediaId',
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
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddFileRequest
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
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
