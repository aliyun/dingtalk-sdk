<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetCustomerInsightResponseBody\result;

use AlibabaCloud\Tea\Model;

class intention extends Model
{
    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $intention;
    protected $_name = [
        'description' => 'description',
        'intention' => 'intention',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->intention) {
            $res['intention'] = $this->intention;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return intention
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['intention'])) {
            $model->intention = $map['intention'];
        }

        return $model;
    }
}
