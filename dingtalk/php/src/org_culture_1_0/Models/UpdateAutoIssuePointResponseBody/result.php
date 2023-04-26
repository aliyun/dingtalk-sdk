<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\UpdateAutoIssuePointResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 1655450856000
     *
     * @var int
     */
    public $nextAutoIssuePointTime;
    protected $_name = [
        'nextAutoIssuePointTime' => 'nextAutoIssuePointTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->nextAutoIssuePointTime) {
            $res['nextAutoIssuePointTime'] = $this->nextAutoIssuePointTime;
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
        if (isset($map['nextAutoIssuePointTime'])) {
            $model->nextAutoIssuePointTime = $map['nextAutoIssuePointTime'];
        }

        return $model;
    }
}
