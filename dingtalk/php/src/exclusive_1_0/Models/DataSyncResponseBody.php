<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class DataSyncResponseBody extends Model
{
    /**
     * @var mixed[][]
     */
    public $dataList;

    /**
     * @example 1
     *
     * @var int
     */
    public $rowsAffected;
    protected $_name = [
        'dataList' => 'dataList',
        'rowsAffected' => 'rowsAffected',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dataList) {
            $res['dataList'] = $this->dataList;
        }
        if (null !== $this->rowsAffected) {
            $res['rowsAffected'] = $this->rowsAffected;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DataSyncResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dataList'])) {
            if (!empty($map['dataList'])) {
                $model->dataList = $map['dataList'];
            }
        }
        if (isset($map['rowsAffected'])) {
            $model->rowsAffected = $map['rowsAffected'];
        }

        return $model;
    }
}
