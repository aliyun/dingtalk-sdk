<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetDingReportSummaryResponseBody extends Model
{
    /**
     * @description 最近1天日志评论用户数
     *
     * @var string
     */
    public $reportCommentUserCnt1d;
    protected $_name = [
        'reportCommentUserCnt1d' => 'reportCommentUserCnt1d',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->reportCommentUserCnt1d) {
            $res['reportCommentUserCnt1d'] = $this->reportCommentUserCnt1d;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDingReportSummaryResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['reportCommentUserCnt1d'])) {
            $model->reportCommentUserCnt1d = $map['reportCommentUserCnt1d'];
        }

        return $model;
    }
}
