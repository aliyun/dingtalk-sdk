<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetDoubleRandomResponseBody extends Model
{
    /**
     * @example [     {       "InspectPlanId": "44030020191021",       "InspectTypeName": "定向",       "InspectPlanName": "2019能效标识生产企业计量监督抽查1",       "InspectItem": "",       "InspectResult": "",       "InspectDepartment": "深圳市市场监督管理局龙岗局",       "InspectDate": "2019-10-14",       "InspectTaskId": "44030020191021",       "InspectTaskName": "2019能效标识生产企业计量监督抽查1"     }   ]
     *
     * @var string
     */
    public $data;

    /**
     * @var int
     */
    public $total;
    protected $_name = [
        'data' => 'data',
        'total' => 'total',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->data) {
            $res['data'] = $this->data;
        }
        if (null !== $this->total) {
            $res['total'] = $this->total;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDoubleRandomResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['data'])) {
            $model->data = $map['data'];
        }
        if (isset($map['total'])) {
            $model->total = $map['total'];
        }

        return $model;
    }
}
