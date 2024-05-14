<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateEduAssetSpaceRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 目前仅支持soke
     *
     * @var string
     */
    public $bizCode;

    /**
     * @description This parameter is required.
     *
     * @example 存放语文教研文件
     *
     * @var string
     */
    public $spaceDesc;

    /**
     * @description This parameter is required.
     *
     * @example https://gw.alicdn.com/imgextra/i4/O1CN01QGjRTl27z8YPPEQdr_!!6000000007867-2-tps-99-78.png
     *
     * @var string
     */
    public $spaceIcon;

    /**
     * @description This parameter is required.
     *
     * @example 语文教研组空间
     *
     * @var string
     */
    public $spaceName;

    /**
     * @description This parameter is required.
     *
     * @example aa12324
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'bizCode'   => 'bizCode',
        'spaceDesc' => 'spaceDesc',
        'spaceIcon' => 'spaceIcon',
        'spaceName' => 'spaceName',
        'userId'    => 'userId',
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
        if (null !== $this->spaceDesc) {
            $res['spaceDesc'] = $this->spaceDesc;
        }
        if (null !== $this->spaceIcon) {
            $res['spaceIcon'] = $this->spaceIcon;
        }
        if (null !== $this->spaceName) {
            $res['spaceName'] = $this->spaceName;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateEduAssetSpaceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['spaceDesc'])) {
            $model->spaceDesc = $map['spaceDesc'];
        }
        if (isset($map['spaceIcon'])) {
            $model->spaceIcon = $map['spaceIcon'];
        }
        if (isset($map['spaceName'])) {
            $model->spaceName = $map['spaceName'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
