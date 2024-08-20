<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSignRecordByUserIdRequest extends Model
{
    /**
     * @example 10
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example 0
     *
     * @var int
     */
    public $nextToken;

    /**
     * @var string[]
     */
    public $signStatus;

    /**
     * @description This parameter is required.
     *
     * @example 660658
     *
     * @var string
     */
    public $signUserId;
    protected $_name = [
        'maxResults' => 'maxResults',
        'nextToken'  => 'nextToken',
        'signStatus' => 'signStatus',
        'signUserId' => 'signUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->signStatus) {
            $res['signStatus'] = $this->signStatus;
        }
        if (null !== $this->signUserId) {
            $res['signUserId'] = $this->signUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSignRecordByUserIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['signStatus'])) {
            if (!empty($map['signStatus'])) {
                $model->signStatus = $map['signStatus'];
            }
        }
        if (isset($map['signUserId'])) {
            $model->signUserId = $map['signUserId'];
        }

        return $model;
    }
}
