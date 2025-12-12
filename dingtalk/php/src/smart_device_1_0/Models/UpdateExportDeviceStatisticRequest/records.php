<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\UpdateExportDeviceStatisticRequest;

use AlibabaCloud\Tea\Model;

class records extends Model
{
    /**
     * @var mixed[]
     */
    public $fields;

    /**
     * @var string
     */
    public $sheetName;
    protected $_name = [
        'fields' => 'fields',
        'sheetName' => 'sheetName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->fields) {
            $res['fields'] = $this->fields;
        }
        if (null !== $this->sheetName) {
            $res['sheetName'] = $this->sheetName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return records
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fields'])) {
            $model->fields = $map['fields'];
        }
        if (isset($map['sheetName'])) {
            $model->sheetName = $map['sheetName'];
        }

        return $model;
    }
}
