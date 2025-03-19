<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryBaymaxSkillLogRequest extends Model
{
    /**
     * @var int
     */
    public $from;

    /**
     * @description This parameter is required.
     *
     * @example 14da****2760
     *
     * @var string
     */
    public $logLevel;

    /**
     * @description This parameter is required.
     *
     * @example 14da****2760
     *
     * @var string
     */
    public $skillExecuteId;

    /**
     * @var int
     */
    public $to;
    protected $_name = [
        'from' => 'from',
        'logLevel' => 'logLevel',
        'skillExecuteId' => 'skillExecuteId',
        'to' => 'to',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->from) {
            $res['from'] = $this->from;
        }
        if (null !== $this->logLevel) {
            $res['logLevel'] = $this->logLevel;
        }
        if (null !== $this->skillExecuteId) {
            $res['skillExecuteId'] = $this->skillExecuteId;
        }
        if (null !== $this->to) {
            $res['to'] = $this->to;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryBaymaxSkillLogRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['from'])) {
            $model->from = $map['from'];
        }
        if (isset($map['logLevel'])) {
            $model->logLevel = $map['logLevel'];
        }
        if (isset($map['skillExecuteId'])) {
            $model->skillExecuteId = $map['skillExecuteId'];
        }
        if (isset($map['to'])) {
            $model->to = $map['to'];
        }

        return $model;
    }
}
