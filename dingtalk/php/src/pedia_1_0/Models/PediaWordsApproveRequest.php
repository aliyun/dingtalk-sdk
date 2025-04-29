<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models;

use AlibabaCloud\Tea\Model;

class PediaWordsApproveRequest extends Model
{
    /**
     * @var bool
     */
    public $aliDocHighLight;

    /**
     * @example 拒绝
     *
     * @var string
     */
    public $approveReason;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var string
     */
    public $approveStatus;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $imHighLight;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $simHighLight;

    /**
     * @description This parameter is required.
     *
     * @example 232432
     *
     * @var string
     */
    public $userId;

    /**
     * @description This parameter is required.
     *
     * @example 1213132
     *
     * @var int
     */
    public $uuid;
    protected $_name = [
        'aliDocHighLight' => 'aliDocHighLight',
        'approveReason' => 'approveReason',
        'approveStatus' => 'approveStatus',
        'imHighLight' => 'imHighLight',
        'simHighLight' => 'simHighLight',
        'userId' => 'userId',
        'uuid' => 'uuid',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->aliDocHighLight) {
            $res['aliDocHighLight'] = $this->aliDocHighLight;
        }
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
        if (isset($map['aliDocHighLight'])) {
            $model->aliDocHighLight = $map['aliDocHighLight'];
        }
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
