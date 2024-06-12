<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryMinutesSummaryResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryMinutesSummaryResponseBody\summary\actions;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryMinutesSummaryResponseBody\summary\autoChapters;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryMinutesSummaryResponseBody\summary\conversationalSummary;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryMinutesSummaryResponseBody\summary\keySentences;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryMinutesSummaryResponseBody\summary\questionsAnsweringSummary;
use AlibabaCloud\Tea\Model;

class summary extends Model
{
    /**
     * @var actions
     */
    public $actions;

    /**
     * @var autoChapters[]
     */
    public $autoChapters;

    /**
     * @var conversationalSummary[]
     */
    public $conversationalSummary;

    /**
     * @var keySentences
     */
    public $keySentences;

    /**
     * @var string[]
     */
    public $keywords;

    /**
     * @var string
     */
    public $paragraphSummary;

    /**
     * @var questionsAnsweringSummary[]
     */
    public $questionsAnsweringSummary;
    protected $_name = [
        'actions'                   => 'actions',
        'autoChapters'              => 'autoChapters',
        'conversationalSummary'     => 'conversationalSummary',
        'keySentences'              => 'keySentences',
        'keywords'                  => 'keywords',
        'paragraphSummary'          => 'paragraphSummary',
        'questionsAnsweringSummary' => 'questionsAnsweringSummary',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actions) {
            $res['actions'] = null !== $this->actions ? $this->actions->toMap() : null;
        }
        if (null !== $this->autoChapters) {
            $res['autoChapters'] = [];
            if (null !== $this->autoChapters && \is_array($this->autoChapters)) {
                $n = 0;
                foreach ($this->autoChapters as $item) {
                    $res['autoChapters'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->conversationalSummary) {
            $res['conversationalSummary'] = [];
            if (null !== $this->conversationalSummary && \is_array($this->conversationalSummary)) {
                $n = 0;
                foreach ($this->conversationalSummary as $item) {
                    $res['conversationalSummary'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->keySentences) {
            $res['keySentences'] = null !== $this->keySentences ? $this->keySentences->toMap() : null;
        }
        if (null !== $this->keywords) {
            $res['keywords'] = $this->keywords;
        }
        if (null !== $this->paragraphSummary) {
            $res['paragraphSummary'] = $this->paragraphSummary;
        }
        if (null !== $this->questionsAnsweringSummary) {
            $res['questionsAnsweringSummary'] = [];
            if (null !== $this->questionsAnsweringSummary && \is_array($this->questionsAnsweringSummary)) {
                $n = 0;
                foreach ($this->questionsAnsweringSummary as $item) {
                    $res['questionsAnsweringSummary'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return summary
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actions'])) {
            $model->actions = actions::fromMap($map['actions']);
        }
        if (isset($map['autoChapters'])) {
            if (!empty($map['autoChapters'])) {
                $model->autoChapters = [];
                $n                   = 0;
                foreach ($map['autoChapters'] as $item) {
                    $model->autoChapters[$n++] = null !== $item ? autoChapters::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['conversationalSummary'])) {
            if (!empty($map['conversationalSummary'])) {
                $model->conversationalSummary = [];
                $n                            = 0;
                foreach ($map['conversationalSummary'] as $item) {
                    $model->conversationalSummary[$n++] = null !== $item ? conversationalSummary::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['keySentences'])) {
            $model->keySentences = keySentences::fromMap($map['keySentences']);
        }
        if (isset($map['keywords'])) {
            if (!empty($map['keywords'])) {
                $model->keywords = $map['keywords'];
            }
        }
        if (isset($map['paragraphSummary'])) {
            $model->paragraphSummary = $map['paragraphSummary'];
        }
        if (isset($map['questionsAnsweringSummary'])) {
            if (!empty($map['questionsAnsweringSummary'])) {
                $model->questionsAnsweringSummary = [];
                $n                                = 0;
                foreach ($map['questionsAnsweringSummary'] as $item) {
                    $model->questionsAnsweringSummary[$n++] = null !== $item ? questionsAnsweringSummary::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
