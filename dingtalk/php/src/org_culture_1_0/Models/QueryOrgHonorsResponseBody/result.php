<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryOrgHonorsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryOrgHonorsResponseBody\result\openHonors;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 下次获取数据的游标
     *
     * @var string
     */
    public $nextToken;

    /**
     * @var openHonors[]
     */
    public $openHonors;
    protected $_name = [
        'nextToken'  => 'nextToken',
        'openHonors' => 'openHonors',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->openHonors) {
            $res['openHonors'] = [];
            if (null !== $this->openHonors && \is_array($this->openHonors)) {
                $n = 0;
                foreach ($this->openHonors as $item) {
                    $res['openHonors'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['openHonors'])) {
            if (!empty($map['openHonors'])) {
                $model->openHonors = [];
                $n                 = 0;
                foreach ($map['openHonors'] as $item) {
                    $model->openHonors[$n++] = null !== $item ? openHonors::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
