<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetOrgResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetOrgResponseBody\org\partitions;
use AlibabaCloud\Tea\Model;

class org extends Model
{
    /**
     * @description 企业id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 分区容量信息
     * 2
     * @var partitions[]
     */
    public $partitions;
    protected $_name = [
        'corpId'     => 'corpId',
        'partitions' => 'partitions',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->partitions) {
            $res['partitions'] = [];
            if (null !== $this->partitions && \is_array($this->partitions)) {
                $n = 0;
                foreach ($this->partitions as $item) {
                    $res['partitions'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return org
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['partitions'])) {
            if (!empty($map['partitions'])) {
                $model->partitions = [];
                $n                 = 0;
                foreach ($map['partitions'] as $item) {
                    $model->partitions[$n++] = null !== $item ? partitions::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
