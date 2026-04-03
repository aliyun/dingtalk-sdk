<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListAiMinutesRequest extends Model
{
    /**
     * @var bool
     */
    public $fetchAll;
    protected $_name = [
        'fetchAll' => 'fetchAll',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->fetchAll) {
            $res['fetchAll'] = $this->fetchAll;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListAiMinutesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fetchAll'])) {
            $model->fetchAll = $map['fetchAll'];
        }

        return $model;
    }
}
