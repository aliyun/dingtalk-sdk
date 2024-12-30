<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractCompareResultResponseBody\result\data\compareDetail;

use AlibabaCloud\Tea\Model;

class details extends Model
{
    /**
     * @var string
     */
    public $compareWords;

    /**
     * @var string
     */
    public $originalWords;

    /**
     * @var int
     */
    public $type;
    protected $_name = [
        'compareWords'  => 'compareWords',
        'originalWords' => 'originalWords',
        'type'          => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->compareWords) {
            $res['compareWords'] = $this->compareWords;
        }
        if (null !== $this->originalWords) {
            $res['originalWords'] = $this->originalWords;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return details
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['compareWords'])) {
            $model->compareWords = $map['compareWords'];
        }
        if (isset($map['originalWords'])) {
            $model->originalWords = $map['originalWords'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
