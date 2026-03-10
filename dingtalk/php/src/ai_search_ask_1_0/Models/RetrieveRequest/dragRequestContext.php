<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\RetrieveRequest;

use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\RetrieveRequest\dragRequestContext\evaluationContext;
use AlibabaCloud\Tea\Model;

class dragRequestContext extends Model
{
    /**
     * @var evaluationContext
     */
    public $evaluationContext;
    protected $_name = [
        'evaluationContext' => 'evaluationContext',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->evaluationContext) {
            $res['evaluationContext'] = null !== $this->evaluationContext ? $this->evaluationContext->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return dragRequestContext
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['evaluationContext'])) {
            $model->evaluationContext = evaluationContext::fromMap($map['evaluationContext']);
        }

        return $model;
    }
}
