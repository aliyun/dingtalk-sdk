<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateEduAssetSpaceRequest extends Model
{
    /**
     * @description 业务类型编码
     *
     * @var string
     */
    public $bizCode;

    /**
     * @description 空间描述
     *
     * @var string
     */
    public $spaceDesc;

    /**
     * @description 空间图标
     *
     * @var string
     */
    public $spaceIcon;

    /**
     * @description 空间名称
     *
     * @var string
     */
    public $spaceName;

    /**
     * @description 用户staffId
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
