<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportLabelInventoryRequest;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @var mixed[]
     */
    public $extendInfo;

    /**
     * @var string
     */
    public $period;

    /**
     * @var string
     */
    public $workNo;
    protected $_name = [
        'extendInfo' => 'extendInfo',
        'period'     => 'period',
        'workNo'     => 'workNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->extendInfo) {
            $res['extendInfo'] = $this->extendInfo;
        }
        if (null !== $this->period) {
            $res['period'] = $this->period;
        }
        if (null !== $this->workNo) {
            $res['workNo'] = $this->workNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return body
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['extendInfo'])) {
            $model->extendInfo = $map['extendInfo'];
        }
        if (isset($map['period'])) {
            $model->period = $map['period'];
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
