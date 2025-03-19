<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetColumnvalsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetColumnvalsResponseBody\result\columnData;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var columnData[]
     */
    public $columnData;

    /**
     * @example manager123
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'columnData' => 'columnData',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->columnData) {
            $res['columnData'] = [];
            if (null !== $this->columnData && \is_array($this->columnData)) {
                $n = 0;
                foreach ($this->columnData as $item) {
                    $res['columnData'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['columnData'])) {
            if (!empty($map['columnData'])) {
                $model->columnData = [];
                $n = 0;
                foreach ($map['columnData'] as $item) {
                    $model->columnData[$n++] = null !== $item ? columnData::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
