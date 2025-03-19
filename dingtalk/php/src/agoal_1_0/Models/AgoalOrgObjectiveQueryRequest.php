<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class AgoalOrgObjectiveQueryRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 662e006fe4b0f579bbcxxxxx
     *
     * @var string
     */
    public $objectiveId;
    protected $_name = [
        'objectiveId' => 'objectiveId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->objectiveId) {
            $res['objectiveId'] = $this->objectiveId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AgoalOrgObjectiveQueryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['objectiveId'])) {
            $model->objectiveId = $map['objectiveId'];
        }

        return $model;
    }
}
