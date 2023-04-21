<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models;

use AlibabaCloud\Tea\Model;

class PediaWordsApproveRequest extends Model
{
    /**
     * @description 拒绝的原因，可选
     *
     * @var string
     */
    public $approveReason;

    /**
     * @description 审核的结果，1通过0代表拒绝
     *
     * @var string
     */
    public $approveStatus;

    /**
     * @description 当前内部群是否高亮
     *
     * @var bool
     */
    public $imHighLight;

    /**
     * @description 服务群是否高亮
     *
     * @var bool
     */
    public $simHighLight;

    /**
     * @description 操作人的组织员工编号，开放平台员工信息接口获取userId
     *
     * @var string
     */
    public $userId;

    /**
     * @description 当前审核的词条的主键编号
     *
     * @var int
     */
    public $uuid;
    protected $_name = [
        'approveReason' => 'approveReason',
        'approveStatus' => 'approveStatus',
        'imHighLight'   => 'imHighLight',
        'simHighLight'  => 'simHighLight',
        'userId'        => 'userId',
        'uuid'          => 'uuid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->approveReason) {
            $res['approveReason'] = $this->approveReason;
        }
        if (null !== $this->approveStatus) {
            $res['approveStatus'] = $this->approveStatus;
        }
        if (null !== $this->imHighLight) {
            $res['imHighLight'] = $this->imHighLight;
        }
        if (null !== $this->simHighLight) {
            $res['simHighLight'] = $this->simHighLight;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PediaWordsApproveRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['approveReason'])) {
            $model->approveReason = $map['approveReason'];
        }
        if (isset($map['approveStatus'])) {
            $model->approveStatus = $map['approveStatus'];
        }
        if (isset($map['imHighLight'])) {
            $model->imHighLight = $map['imHighLight'];
        }
        if (isset($map['simHighLight'])) {
            $model->simHighLight = $map['simHighLight'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
