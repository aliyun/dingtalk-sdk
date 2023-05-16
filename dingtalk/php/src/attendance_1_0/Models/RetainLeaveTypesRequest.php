<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class RetainLeaveTypesRequest extends Model
{
    /**
     * @var string[]
     */
    public $leaveCodes;

    /**
     * @example manager233
     *
     * @var string
     */
    public $opUserId;

    /**
     * @example 1
     *
     * @var int
     */
    public $source;
    protected $_name = [
        'leaveCodes' => 'leaveCodes',
        'opUserId'   => 'opUserId',
        'source'     => 'source',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->leaveCodes) {
            $res['leaveCodes'] = $this->leaveCodes;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RetainLeaveTypesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['leaveCodes'])) {
            if (!empty($map['leaveCodes'])) {
                $model->leaveCodes = $map['leaveCodes'];
            }
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }

        return $model;
    }
}
