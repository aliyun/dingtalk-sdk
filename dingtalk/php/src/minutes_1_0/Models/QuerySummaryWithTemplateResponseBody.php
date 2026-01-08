<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\Tea\Model;

class QuerySummaryWithTemplateResponseBody extends Model
{
    /**
     * @var string
     */
    public $summaryText;
    protected $_name = [
        'summaryText' => 'summaryText',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->summaryText) {
            $res['summaryText'] = $this->summaryText;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QuerySummaryWithTemplateResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['summaryText'])) {
            $model->summaryText = $map['summaryText'];
        }

        return $model;
    }
}
