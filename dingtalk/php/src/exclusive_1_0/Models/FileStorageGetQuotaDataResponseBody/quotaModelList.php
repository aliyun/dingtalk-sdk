<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\FileStorageGetQuotaDataResponseBody;

use AlibabaCloud\Tea\Model;

class quotaModelList extends Model
{
    /**
     * @description 统计时间点
     *
     * @var string
     */
    public $statisticTime;

    /**
     * @description 使用的容量（byte）
     *
     * @var int
     */
    public $usedStorage;
    protected $_name = [
        'statisticTime' => 'statisticTime',
        'usedStorage'   => 'usedStorage',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->statisticTime) {
            $res['statisticTime'] = $this->statisticTime;
        }
        if (null !== $this->usedStorage) {
            $res['usedStorage'] = $this->usedStorage;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return quotaModelList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['statisticTime'])) {
            $model->statisticTime = $map['statisticTime'];
        }
        if (isset($map['usedStorage'])) {
            $model->usedStorage = $map['usedStorage'];
        }

        return $model;
    }
}
