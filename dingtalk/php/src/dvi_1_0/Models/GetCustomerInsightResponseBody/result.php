<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetCustomerInsightResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetCustomerInsightResponseBody\result\intention;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetCustomerInsightResponseBody\result\tag;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var intention
     */
    public $intention;

    /**
     * @var tag
     */
    public $tag;
    protected $_name = [
        'intention' => 'intention',
        'tag' => 'tag',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->intention) {
            $res['intention'] = null !== $this->intention ? $this->intention->toMap() : null;
        }
        if (null !== $this->tag) {
            $res['tag'] = null !== $this->tag ? $this->tag->toMap() : null;
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
        if (isset($map['intention'])) {
            $model->intention = intention::fromMap($map['intention']);
        }
        if (isset($map['tag'])) {
            $model->tag = tag::fromMap($map['tag']);
        }

        return $model;
    }
}
