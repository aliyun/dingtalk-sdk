<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SchoolReportDetailReadedResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string[]
     */
    public $schoolReportDetailId;
    protected $_name = [
        'schoolReportDetailId' => 'schoolReportDetailId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->schoolReportDetailId) {
            $res['schoolReportDetailId'] = $this->schoolReportDetailId;
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
        if (isset($map['schoolReportDetailId'])) {
            if (!empty($map['schoolReportDetailId'])) {
                $model->schoolReportDetailId = $map['schoolReportDetailId'];
            }
        }

        return $model;
    }
}
