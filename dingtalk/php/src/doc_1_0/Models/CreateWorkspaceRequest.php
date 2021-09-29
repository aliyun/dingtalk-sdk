<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateWorkspaceRequest extends Model
{
    /**
     * @description 团队空间名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 团队空间描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $operatorId;

    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @var int
     */
    public $dingUid;

    /**
     * @var string
     */
    public $dingAccessTokenType;

    /**
     * @var int
     */
    public $dingIsvOrgId;
    protected $_name = [
        'name'                => 'name',
        'description'         => 'description',
        'operatorId'          => 'operatorId',
        'dingOrgId'           => 'dingOrgId',
        'dingUid'             => 'dingUid',
        'dingAccessTokenType' => 'dingAccessTokenType',
        'dingIsvOrgId'        => 'dingIsvOrgId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingUid) {
            $res['dingUid'] = $this->dingUid;
        }
        if (null !== $this->dingAccessTokenType) {
            $res['dingAccessTokenType'] = $this->dingAccessTokenType;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateWorkspaceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingUid'])) {
            $model->dingUid = $map['dingUid'];
        }
        if (isset($map['dingAccessTokenType'])) {
            $model->dingAccessTokenType = $map['dingAccessTokenType'];
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }

        return $model;
    }
}
