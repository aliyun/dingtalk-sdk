<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteSchoolReportResponseBody\result;
use AlibabaCloud\Tea\Model;

class DeleteSchoolReportResponseBody extends Model
{
    /**
     * @var result
     */
    public $result;

    /**
     * @var bool
     */
    public $success;
    protected $_name = [
        'result'  => 'result',
        'success' => 'success',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->result) {
            $res['result'] = null !== $this->result ? $this->result->toMap() : null;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteSchoolReportResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['result'])) {
            $model->result = result::fromMap($map['result']);
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
