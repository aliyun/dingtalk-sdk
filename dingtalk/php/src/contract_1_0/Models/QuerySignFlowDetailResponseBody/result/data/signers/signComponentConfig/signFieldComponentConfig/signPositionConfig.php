<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySignFlowDetailResponseBody\result\data\signers\signComponentConfig\signFieldComponentConfig;

use AlibabaCloud\Tea\Model;

class signPositionConfig extends Model
{
    /**
     * @var int
     */
    public $positionPage;

    /**
     * @var float
     */
    public $positionX;

    /**
     * @var float
     */
    public $positionY;
    protected $_name = [
        'positionPage' => 'positionPage',
        'positionX' => 'positionX',
        'positionY' => 'positionY',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->positionPage) {
            $res['positionPage'] = $this->positionPage;
        }
        if (null !== $this->positionX) {
            $res['positionX'] = $this->positionX;
        }
        if (null !== $this->positionY) {
            $res['positionY'] = $this->positionY;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return signPositionConfig
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['positionPage'])) {
            $model->positionPage = $map['positionPage'];
        }
        if (isset($map['positionX'])) {
            $model->positionX = $map['positionX'];
        }
        if (isset($map['positionY'])) {
            $model->positionY = $map['positionY'];
        }

        return $model;
    }
}
