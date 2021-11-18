<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PollingConfirmStatusResponseBody\universityPollingCourseStatusResponse;
use AlibabaCloud\Tea\Model;

class PollingConfirmStatusResponseBody extends Model
{
    /**
     * @var universityPollingCourseStatusResponse
     */
    public $universityPollingCourseStatusResponse;
    protected $_name = [
        'universityPollingCourseStatusResponse' => 'universityPollingCourseStatusResponse',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->universityPollingCourseStatusResponse) {
            $res['universityPollingCourseStatusResponse'] = null !== $this->universityPollingCourseStatusResponse ? $this->universityPollingCourseStatusResponse->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PollingConfirmStatusResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['universityPollingCourseStatusResponse'])) {
            $model->universityPollingCourseStatusResponse = universityPollingCourseStatusResponse::fromMap($map['universityPollingCourseStatusResponse']);
        }

        return $model;
    }
}
