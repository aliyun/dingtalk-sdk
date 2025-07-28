<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PublishSchoolReportResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var int
     */
    public $schoolReportId;
    protected $_name = [
        'schoolReportId' => 'schoolReportId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->schoolReportId) {
            $res['schoolReportId'] = $this->schoolReportId;
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
        if (isset($map['schoolReportId'])) {
            $model->schoolReportId = $map['schoolReportId'];
        }

        return $model;
    }
}
