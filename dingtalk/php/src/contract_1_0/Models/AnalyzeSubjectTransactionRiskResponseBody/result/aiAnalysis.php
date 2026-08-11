<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\AnalyzeSubjectTransactionRiskResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\AnalyzeSubjectTransactionRiskResponseBody\result\aiAnalysis\keyRisks;
use AlibabaCloud\Tea\Model;

class aiAnalysis extends Model
{
    /**
     * @var keyRisks[]
     */
    public $keyRisks;

    /**
     * @var string[]
     */
    public $limitations;

    /**
     * @var string
     */
    public $status;

    /**
     * @var string
     */
    public $summary;
    protected $_name = [
        'keyRisks' => 'keyRisks',
        'limitations' => 'limitations',
        'status' => 'status',
        'summary' => 'summary',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->keyRisks) {
            $res['keyRisks'] = [];
            if (null !== $this->keyRisks && \is_array($this->keyRisks)) {
                $n = 0;
                foreach ($this->keyRisks as $item) {
                    $res['keyRisks'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->limitations) {
            $res['limitations'] = $this->limitations;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->summary) {
            $res['summary'] = $this->summary;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return aiAnalysis
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['keyRisks'])) {
            if (!empty($map['keyRisks'])) {
                $model->keyRisks = [];
                $n = 0;
                foreach ($map['keyRisks'] as $item) {
                    $model->keyRisks[$n++] = null !== $item ? keyRisks::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['limitations'])) {
            if (!empty($map['limitations'])) {
                $model->limitations = $map['limitations'];
            }
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['summary'])) {
            $model->summary = $map['summary'];
        }

        return $model;
    }
}
