<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryMinutesMeetingResultResponseBody extends Model
{
    /**
     * @var string[]
     */
    public $action;

    /**
     * @var string
     */
    public $fullSummary;
    protected $_name = [
        'action' => 'action',
        'fullSummary' => 'fullSummary',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->action) {
            $res['action'] = $this->action;
        }
        if (null !== $this->fullSummary) {
            $res['fullSummary'] = $this->fullSummary;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryMinutesMeetingResultResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['action'])) {
            if (!empty($map['action'])) {
                $model->action = $map['action'];
            }
        }
        if (isset($map['fullSummary'])) {
            $model->fullSummary = $map['fullSummary'];
        }

        return $model;
    }
}
