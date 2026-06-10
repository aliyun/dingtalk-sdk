<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CopyDocWithAppAuthResponseBody\syncCopyResult;
use AlibabaCloud\Tea\Model;

class CopyDocWithAppAuthResponseBody extends Model
{
    /**
     * @var bool
     */
    public $isAsync;

    /**
     * @var syncCopyResult
     */
    public $syncCopyResult;

    /**
     * @var string
     */
    public $taskId;
    protected $_name = [
        'isAsync' => 'isAsync',
        'syncCopyResult' => 'syncCopyResult',
        'taskId' => 'taskId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->isAsync) {
            $res['isAsync'] = $this->isAsync;
        }
        if (null !== $this->syncCopyResult) {
            $res['syncCopyResult'] = null !== $this->syncCopyResult ? $this->syncCopyResult->toMap() : null;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CopyDocWithAppAuthResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isAsync'])) {
            $model->isAsync = $map['isAsync'];
        }
        if (isset($map['syncCopyResult'])) {
            $model->syncCopyResult = syncCopyResult::fromMap($map['syncCopyResult']);
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }

        return $model;
    }
}
