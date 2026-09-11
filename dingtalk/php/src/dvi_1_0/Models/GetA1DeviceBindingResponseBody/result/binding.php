<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetA1DeviceBindingResponseBody\result;

use AlibabaCloud\Tea\Model;

class binding extends Model
{
    /**
     * @var int
     */
    public $bindTimestamp;

    /**
     * @var string
     */
    public $bindingStatus;

    /**
     * @var string
     */
    public $sn;

    /**
     * @var string
     */
    public $unionId;
    protected $_name = [
        'bindTimestamp' => 'bindTimestamp',
        'bindingStatus' => 'bindingStatus',
        'sn' => 'sn',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bindTimestamp) {
            $res['bindTimestamp'] = $this->bindTimestamp;
        }
        if (null !== $this->bindingStatus) {
            $res['bindingStatus'] = $this->bindingStatus;
        }
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return binding
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bindTimestamp'])) {
            $model->bindTimestamp = $map['bindTimestamp'];
        }
        if (isset($map['bindingStatus'])) {
            $model->bindingStatus = $map['bindingStatus'];
        }
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
