<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models;

use AlibabaCloud\Tea\Model;

class HrbrainTalentSearchRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $query;

    /**
     * @var string
     */
    public $sessionId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $workNo;
    protected $_name = [
        'query' => 'query',
        'sessionId' => 'sessionId',
        'workNo' => 'workNo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->query) {
            $res['query'] = $this->query;
        }
        if (null !== $this->sessionId) {
            $res['sessionId'] = $this->sessionId;
        }
        if (null !== $this->workNo) {
            $res['workNo'] = $this->workNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return HrbrainTalentSearchRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['query'])) {
            $model->query = $map['query'];
        }
        if (isset($map['sessionId'])) {
            $model->sessionId = $map['sessionId'];
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
