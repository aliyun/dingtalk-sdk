<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddFollowRecordsRequest;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddFollowRecordsRequest\instanceList\dataArray;
use AlibabaCloud\Tea\Model;

class instanceList extends Model
{
    /**
     * @var string[]
     */
    public $bizExtMap;

    /**
     * @description This parameter is required.
     *
     * @var dataArray[]
     */
    public $dataArray;
    protected $_name = [
        'bizExtMap' => 'bizExtMap',
        'dataArray' => 'dataArray',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizExtMap) {
            $res['bizExtMap'] = $this->bizExtMap;
        }
        if (null !== $this->dataArray) {
            $res['dataArray'] = [];
            if (null !== $this->dataArray && \is_array($this->dataArray)) {
                $n = 0;
                foreach ($this->dataArray as $item) {
                    $res['dataArray'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (isset($map['bizExtMap'])) {
            $model->bizExtMap = $map['bizExtMap'];
        }
        if (isset($map['dataArray'])) {
            if (!empty($map['dataArray'])) {
                $model->dataArray = [];
                $n                = 0;
                foreach ($map['dataArray'] as $item) {
                    $model->dataArray[$n++] = null !== $item ? dataArray::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
