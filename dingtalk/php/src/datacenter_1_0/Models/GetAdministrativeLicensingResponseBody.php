<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetAdministrativeLicensingResponseBody extends Model
{
    /**
     * @example [     {       "LicenseNo": "梯4403331978",       "StartDate": "2022-05-10",       "Department": "深圳市市场监督管理局",       "Content": "注册代码:7;设备种类:电梯",       "LicenseName": "特种设备使用登记",       "EndDate": "2099-12-31"     },     {       "LicenseNo": "东水务审﹝2021﹞8267号",       "StartDate": "2021-06-11",       "Department": "东莞市水务局",       "Content": "水土保持方案审批准予行政许可决定",       "LicenseName": "",       "EndDate": "2026-12-31"     } ]
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
     * @return GetAdministrativeLicensingResponseBody
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
