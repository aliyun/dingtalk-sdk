<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskStartdateResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 2022-07-04T03:29:34.770Z
     *
     * @var string
     */
    public $startDate;

    /**
     * @example 2022-07-04T03:29:34.770Z
     *
     * @var string
     */
    public $updated;
    protected $_name = [
        'startDate' => 'startDate',
        'updated'   => 'updated',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }
        if (null !== $this->updated) {
            $res['updated'] = $this->updated;
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
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }
        if (isset($map['updated'])) {
            $model->updated = $map['updated'];
        }

        return $model;
    }
}
