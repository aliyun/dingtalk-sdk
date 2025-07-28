<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\RevertPointResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var int
     */
    public $revertedPoints;
    protected $_name = [
        'revertedPoints' => 'revertedPoints',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->revertedPoints) {
            $res['revertedPoints'] = $this->revertedPoints;
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
        if (isset($map['revertedPoints'])) {
            $model->revertedPoints = $map['revertedPoints'];
        }

        return $model;
    }
}
