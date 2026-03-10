<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetContractReviewResultResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetContractReviewResultResponseBody\result\annotations;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetContractReviewResultResponseBody\result\summary;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var annotations[]
     */
    public $annotations;

    /**
     * @var string
     */
    public $clearWordPath;

    /**
     * @var string
     */
    public $reviewType;

    /**
     * @var string
     */
    public $status;

    /**
     * @var summary
     */
    public $summary;

    /**
     * @var string
     */
    public $wordPath;
    protected $_name = [
        'annotations' => 'annotations',
        'clearWordPath' => 'clearWordPath',
        'reviewType' => 'reviewType',
        'status' => 'status',
        'summary' => 'summary',
        'wordPath' => 'wordPath',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->annotations) {
            $res['annotations'] = [];
            if (null !== $this->annotations && \is_array($this->annotations)) {
                $n = 0;
                foreach ($this->annotations as $item) {
                    $res['annotations'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->clearWordPath) {
            $res['clearWordPath'] = $this->clearWordPath;
        }
        if (null !== $this->reviewType) {
            $res['reviewType'] = $this->reviewType;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->summary) {
            $res['summary'] = null !== $this->summary ? $this->summary->toMap() : null;
        }
        if (null !== $this->wordPath) {
            $res['wordPath'] = $this->wordPath;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['annotations'])) {
            if (!empty($map['annotations'])) {
                $model->annotations = [];
                $n = 0;
                foreach ($map['annotations'] as $item) {
                    $model->annotations[$n++] = null !== $item ? annotations::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['clearWordPath'])) {
            $model->clearWordPath = $map['clearWordPath'];
        }
        if (isset($map['reviewType'])) {
            $model->reviewType = $map['reviewType'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['summary'])) {
            $model->summary = summary::fromMap($map['summary']);
        }
        if (isset($map['wordPath'])) {
            $model->wordPath = $map['wordPath'];
        }

        return $model;
    }
}
