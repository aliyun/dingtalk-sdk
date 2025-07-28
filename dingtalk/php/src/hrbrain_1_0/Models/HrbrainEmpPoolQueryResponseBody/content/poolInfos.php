<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainEmpPoolQueryResponseBody\content;

use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainEmpPoolQueryResponseBody\content\poolInfos\poolTags;
use AlibabaCloud\Tea\Model;

class poolInfos extends Model
{
    /**
     * @var string
     */
    public $poolCode;

    /**
     * @var string
     */
    public $poolDesc;

    /**
     * @var string
     */
    public $poolName;

    /**
     * @var poolTags[]
     */
    public $poolTags;
    protected $_name = [
        'poolCode' => 'poolCode',
        'poolDesc' => 'poolDesc',
        'poolName' => 'poolName',
        'poolTags' => 'poolTags',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->poolCode) {
            $res['poolCode'] = $this->poolCode;
        }
        if (null !== $this->poolDesc) {
            $res['poolDesc'] = $this->poolDesc;
        }
        if (null !== $this->poolName) {
            $res['poolName'] = $this->poolName;
        }
        if (null !== $this->poolTags) {
            $res['poolTags'] = [];
            if (null !== $this->poolTags && \is_array($this->poolTags)) {
                $n = 0;
                foreach ($this->poolTags as $item) {
                    $res['poolTags'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return poolInfos
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['poolCode'])) {
            $model->poolCode = $map['poolCode'];
        }
        if (isset($map['poolDesc'])) {
            $model->poolDesc = $map['poolDesc'];
        }
        if (isset($map['poolName'])) {
            $model->poolName = $map['poolName'];
        }
        if (isset($map['poolTags'])) {
            if (!empty($map['poolTags'])) {
                $model->poolTags = [];
                $n = 0;
                foreach ($map['poolTags'] as $item) {
                    $model->poolTags[$n++] = null !== $item ? poolTags::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
