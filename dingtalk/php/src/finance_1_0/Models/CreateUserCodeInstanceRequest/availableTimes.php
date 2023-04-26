<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\CreateUserCodeInstanceRequest;

use AlibabaCloud\Tea\Model;

class availableTimes extends Model
{
    /**
     * @example yyyy-MM-dd HH:mm:ss
     *
     * @var string
     */
    public $gmtEnd;

    /**
     * @example yyyy-MM-dd HH:mm:ss
     *
     * @var string
     */
    public $gmtStart;
    protected $_name = [
        'gmtEnd'   => 'gmtEnd',
        'gmtStart' => 'gmtStart',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->gmtEnd) {
            $res['gmtEnd'] = $this->gmtEnd;
        }
        if (null !== $this->gmtStart) {
            $res['gmtStart'] = $this->gmtStart;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return availableTimes
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['gmtEnd'])) {
            $model->gmtEnd = $map['gmtEnd'];
        }
        if (isset($map['gmtStart'])) {
            $model->gmtStart = $map['gmtStart'];
        }

        return $model;
    }
}
