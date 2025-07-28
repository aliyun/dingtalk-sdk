<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\ContractAiReviewResultNotifyRequest;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\ContractAiReviewResultNotifyRequest\annotations\commentTexts;
use AlibabaCloud\Tea\Model;

class annotations extends Model
{
    /**
     * @var commentTexts[]
     */
    public $commentTexts;

    /**
     * @var int
     */
    public $id;

    /**
     * @var string
     */
    public $originalText;

    /**
     * @var string
     */
    public $paragraph;

    /**
     * @var string
     */
    public $riskLevel;
    protected $_name = [
        'commentTexts' => 'commentTexts',
        'id' => 'id',
        'originalText' => 'originalText',
        'paragraph' => 'paragraph',
        'riskLevel' => 'riskLevel',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->commentTexts) {
            $res['commentTexts'] = [];
            if (null !== $this->commentTexts && \is_array($this->commentTexts)) {
                $n = 0;
                foreach ($this->commentTexts as $item) {
                    $res['commentTexts'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->originalText) {
            $res['originalText'] = $this->originalText;
        }
        if (null !== $this->paragraph) {
            $res['paragraph'] = $this->paragraph;
        }
        if (null !== $this->riskLevel) {
            $res['riskLevel'] = $this->riskLevel;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return annotations
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['commentTexts'])) {
            if (!empty($map['commentTexts'])) {
                $model->commentTexts = [];
                $n = 0;
                foreach ($map['commentTexts'] as $item) {
                    $model->commentTexts[$n++] = null !== $item ? commentTexts::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['originalText'])) {
            $model->originalText = $map['originalText'];
        }
        if (isset($map['paragraph'])) {
            $model->paragraph = $map['paragraph'];
        }
        if (isset($map['riskLevel'])) {
            $model->riskLevel = $map['riskLevel'];
        }

        return $model;
    }
}
