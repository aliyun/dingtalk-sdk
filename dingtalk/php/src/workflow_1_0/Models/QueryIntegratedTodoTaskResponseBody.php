<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryIntegratedTodoTaskResponseBody\taskPage;
use AlibabaCloud\Tea\Model;

class QueryIntegratedTodoTaskResponseBody extends Model
{
    /**
     * @var string
     */
    public $requestId;

    /**
     * @var taskPage
     */
    public $taskPage;
    protected $_name = [
        'requestId' => 'requestId',
        'taskPage'  => 'taskPage',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }
        if (null !== $this->taskPage) {
            $res['taskPage'] = null !== $this->taskPage ? $this->taskPage->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryIntegratedTodoTaskResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }
        if (isset($map['taskPage'])) {
            $model->taskPage = taskPage::fromMap($map['taskPage']);
        }

        return $model;
    }
}
