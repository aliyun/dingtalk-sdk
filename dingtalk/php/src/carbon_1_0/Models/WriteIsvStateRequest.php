<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models;

use AlibabaCloud\Tea\Model;

class WriteIsvStateRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example ISV
     *
     * @var string
     */
    public $isvName;

    /**
     * @description This parameter is required.
     *
     * @example 20220328
     *
     * @var string
     */
    public $statDate;
    protected $_name = [
        'isvName' => 'isvName',
        'statDate' => 'statDate',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->isvName) {
            $res['isvName'] = $this->isvName;
        }
        if (null !== $this->statDate) {
            $res['statDate'] = $this->statDate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return WriteIsvStateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isvName'])) {
            $model->isvName = $map['isvName'];
        }
        if (isset($map['statDate'])) {
            $model->statDate = $map['statDate'];
        }

        return $model;
    }
}
