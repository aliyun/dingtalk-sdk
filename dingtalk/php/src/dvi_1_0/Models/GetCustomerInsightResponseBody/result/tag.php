<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetCustomerInsightResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetCustomerInsightResponseBody\result\tag\aiTag;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetCustomerInsightResponseBody\result\tag\userTag;
use AlibabaCloud\Tea\Model;

class tag extends Model
{
    /**
     * @var aiTag[]
     */
    public $aiTag;

    /**
     * @var userTag[]
     */
    public $userTag;
    protected $_name = [
        'aiTag' => 'aiTag',
        'userTag' => 'userTag',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->aiTag) {
            $res['aiTag'] = [];
            if (null !== $this->aiTag && \is_array($this->aiTag)) {
                $n = 0;
                foreach ($this->aiTag as $item) {
                    $res['aiTag'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->userTag) {
            $res['userTag'] = [];
            if (null !== $this->userTag && \is_array($this->userTag)) {
                $n = 0;
                foreach ($this->userTag as $item) {
                    $res['userTag'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return tag
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['aiTag'])) {
            if (!empty($map['aiTag'])) {
                $model->aiTag = [];
                $n = 0;
                foreach ($map['aiTag'] as $item) {
                    $model->aiTag[$n++] = null !== $item ? aiTag::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['userTag'])) {
            if (!empty($map['userTag'])) {
                $model->userTag = [];
                $n = 0;
                foreach ($map['userTag'] as $item) {
                    $model->userTag[$n++] = null !== $item ? userTag::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
