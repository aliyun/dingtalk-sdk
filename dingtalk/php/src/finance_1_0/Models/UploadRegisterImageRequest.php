<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class UploadRegisterImageRequest extends Model
{
    /**
     * @description 图片内容
     *
     * @var string
     */
    public $imageContent;

    /**
     * @description 图片名称
     *
     * @var string
     */
    public $imageName;

    /**
     * @description 图片类型
     *
     * @var string
     */
    public $imageType;

    /**
     * @description 主机构id
     *
     * @var string
     */
    public $instId;

    /**
     * @description 进件渠道
     *
     * @var string
     */
    public $payChannel;
    protected $_name = [
        'imageContent' => 'imageContent',
        'imageName'    => 'imageName',
        'imageType'    => 'imageType',
        'instId'       => 'instId',
        'payChannel'   => 'payChannel',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->imageContent) {
            $res['imageContent'] = $this->imageContent;
        }
        if (null !== $this->imageName) {
            $res['imageName'] = $this->imageName;
        }
        if (null !== $this->imageType) {
            $res['imageType'] = $this->imageType;
        }
        if (null !== $this->instId) {
            $res['instId'] = $this->instId;
        }
        if (null !== $this->payChannel) {
            $res['payChannel'] = $this->payChannel;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UploadRegisterImageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['imageContent'])) {
            $model->imageContent = $map['imageContent'];
        }
        if (isset($map['imageName'])) {
            $model->imageName = $map['imageName'];
        }
        if (isset($map['imageType'])) {
            $model->imageType = $map['imageType'];
        }
        if (isset($map['instId'])) {
            $model->instId = $map['instId'];
        }
        if (isset($map['payChannel'])) {
            $model->payChannel = $map['payChannel'];
        }

        return $model;
    }
}
