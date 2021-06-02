<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\GetDataViewResponseBody\data;
use AlibabaCloud\Tea\Model;

class GetDataViewResponseBody extends Model
{
    /**
     * @var data
     */
    public $data;

    /**
     * @description 字段明细
     *
     * @var mixed[][]
     */
    public $dataname;

    /**
     * @description 响应时间
     *
     * @var string
     */
    public $time;
    protected $_name = [
        'data'     => 'data',
        'dataname' => 'dataname',
        'time'     => 'time',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->data) {
            $res['data'] = null !== $this->data ? $this->data->toMap() : null;
        }
        if (null !== $this->dataname) {
            $res['dataname'] = $this->dataname;
        }
        if (null !== $this->time) {
            $res['time'] = $this->time;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDataViewResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['data'])) {
            $model->data = data::fromMap($map['data']);
        }
        if (isset($map['dataname'])) {
            $model->dataname = $map['dataname'];
        }
        if (isset($map['time'])) {
            $model->time = $map['time'];
        }

        return $model;
    }
}
