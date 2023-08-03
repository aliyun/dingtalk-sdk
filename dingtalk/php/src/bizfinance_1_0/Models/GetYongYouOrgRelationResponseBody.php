<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetYongYouOrgRelationResponseBody extends Model
{
    /**
     * @example 20230731
     *
     * @var string
     */
    public $chanjetCorpId;

    /**
     * @example 01162352501424064728
     *
     * @var string
     */
    public $chanjetUserId;

    /**
     * @example ding9f50b15bccd16741
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 01162352501424064728
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'chanjetCorpId' => 'chanjetCorpId',
        'chanjetUserId' => 'chanjetUserId',
        'corpId'        => 'corpId',
        'userId'        => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->chanjetCorpId) {
            $res['chanjetCorpId'] = $this->chanjetCorpId;
        }
        if (null !== $this->chanjetUserId) {
            $res['chanjetUserId'] = $this->chanjetUserId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetYongYouOrgRelationResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['chanjetCorpId'])) {
            $model->chanjetCorpId = $map['chanjetCorpId'];
        }
        if (isset($map['chanjetUserId'])) {
            $model->chanjetUserId = $map['chanjetUserId'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
