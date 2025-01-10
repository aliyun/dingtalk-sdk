<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models\AgoalPeriodListRequest;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @var string[]
     */
    public $periodTypes;
    protected $_name = [
        'periodTypes' => 'periodTypes',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->periodTypes) {
            $res['periodTypes'] = $this->periodTypes;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return body
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['periodTypes'])) {
            if (!empty($map['periodTypes'])) {
                $model->periodTypes = $map['periodTypes'];
            }
        }

        return $model;
    }
}
