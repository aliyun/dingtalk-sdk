<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\SearchFileKeywordPositionsResponseBody\result\data;

use AlibabaCloud\Tea\Model;

class positions extends Model
{
    /**
     * @var int
     */
    public $index;

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
        'index' => 'index',
        'positionPage' => 'positionPage',
        'positionX' => 'positionX',
        'positionY' => 'positionY',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->index) {
            $res['index'] = $this->index;
        }
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
     * @return positions
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['index'])) {
            $model->index = $map['index'];
        }
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
