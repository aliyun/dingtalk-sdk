<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateEduAssetSpaceRequest extends Model
{
    /**
     * @description 空间名称
     *
     * @var string
     */
    public $spaceName;

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
     * @description 用户staffId
     *
     * @var string
     */
    public $userId;

    /**
     * @description 业务类型编码
     *
     * @var string
     */
    public $bizCode;

    /**
     * @description 组织corpId
     *
     * @var string
     */
    public $dingCorpId;

    /**
     * @description 组织id
     *
     * @var int
     */
    public $dingOrgId;
    protected $_name = [
        'spaceName'  => 'spaceName',
        'spaceDesc'  => 'spaceDesc',
        'spaceIcon'  => 'spaceIcon',
        'userId'     => 'userId',
        'bizCode'    => 'bizCode',
        'dingCorpId' => 'dingCorpId',
        'dingOrgId'  => 'dingOrgId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->spaceName) {
            $res['spaceName'] = $this->spaceName;
        }
        if (null !== $this->spaceDesc) {
            $res['spaceDesc'] = $this->spaceDesc;
        }
        if (null !== $this->spaceIcon) {
            $res['spaceIcon'] = $this->spaceIcon;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
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
        if (isset($map['spaceName'])) {
            $model->spaceName = $map['spaceName'];
        }
        if (isset($map['spaceDesc'])) {
            $model->spaceDesc = $map['spaceDesc'];
        }
        if (isset($map['spaceIcon'])) {
            $model->spaceIcon = $map['spaceIcon'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }

        return $model;
    }
}
