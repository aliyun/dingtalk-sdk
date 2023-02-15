<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchUpdateFollowRecordsRequest;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchUpdateFollowRecordsRequest\instanceList\dataArray;
use AlibabaCloud\Tea\Model;

class instanceList extends Model
{
    /**
     * @description 关系模型数据。
     *
     * @var dataArray[]
     */
    public $dataArray;

    /**
     * @var string
     */
    public $instanceId;
    protected $_name = [
        'dataArray'  => 'dataArray',
        'instanceId' => 'instanceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dataArray) {
            $res['dataArray'] = [];
            if (null !== $this->dataArray && \is_array($this->dataArray)) {
                $n = 0;
                foreach ($this->dataArray as $item) {
                    $res['dataArray'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return instanceList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dataArray'])) {
            if (!empty($map['dataArray'])) {
                $model->dataArray = [];
                $n                = 0;
                foreach ($map['dataArray'] as $item) {
                    $model->dataArray[$n++] = null !== $item ? dataArray::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }

        return $model;
    }
}
