<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class UploadRegisterImageRequest extends Model
{
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

    /**
     * @description 图片类型
     *
     * @var string
     */
    public $imageType;

    /**
     * @description 图片名称
     *
     * @var string
     */
    public $imageName;

    /**
     * @description 图片内容
     *
     * @var string
     */
    public $imageContent;

    /**
     * @description 组织id
     *
     * @var int
     */
    public $dingOrgId;

    /**
     * @description isv组织id
     *
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @description 应用id
     *
     * @var string
     */
    public $dingClientId;

    /**
     * @description 应用类型
     *
     * @var int
     */
    public $dingTokenGrantType;
    protected $_name = [
        'instId'             => 'instId',
        'payChannel'         => 'payChannel',
        'imageType'          => 'imageType',
        'imageName'          => 'imageName',
        'imageContent'       => 'imageContent',
        'dingOrgId'          => 'dingOrgId',
        'dingIsvOrgId'       => 'dingIsvOrgId',
        'dingClientId'       => 'dingClientId',
        'dingTokenGrantType' => 'dingTokenGrantType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->instId) {
            $res['instId'] = $this->instId;
        }
        if (null !== $this->payChannel) {
            $res['payChannel'] = $this->payChannel;
        }
        if (null !== $this->imageType) {
            $res['imageType'] = $this->imageType;
        }
        if (null !== $this->imageName) {
            $res['imageName'] = $this->imageName;
        }
        if (null !== $this->imageContent) {
            $res['imageContent'] = $this->imageContent;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingClientId) {
            $res['dingClientId'] = $this->dingClientId;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
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
        if (isset($map['instId'])) {
            $model->instId = $map['instId'];
        }
        if (isset($map['payChannel'])) {
            $model->payChannel = $map['payChannel'];
        }
        if (isset($map['imageType'])) {
            $model->imageType = $map['imageType'];
        }
        if (isset($map['imageName'])) {
            $model->imageName = $map['imageName'];
        }
        if (isset($map['imageContent'])) {
            $model->imageContent = $map['imageContent'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingClientId'])) {
            $model->dingClientId = $map['dingClientId'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }

        return $model;
    }
}
