<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CopyDocResponseBody\syncCopyResult;
use AlibabaCloud\Tea\Model;

class CopyDocResponseBody extends Model
{
    /**
     * @example true
     *
     * @var bool
     */
    public $isAsync;

    /**
     * @example true
     *
     * @var syncCopyResult
     */
    public $syncCopyResult;

    /**
     * @example true
     *
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
     * @return CopyDocResponseBody
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
