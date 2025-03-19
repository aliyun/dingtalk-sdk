<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardGetCardFinishProgressResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardGetCardFinishProgressResponseBody\result\classStatistics\process;
use AlibabaCloud\Tea\Model;

class classStatistics extends Model
{
    /**
     * @example 234234234
     *
     * @var string
     */
    public $cardBizId;

    /**
     * @example 二年级1班
     *
     * @var string
     */
    public $cardBizName;

    /**
     * @example 3424234
     *
     * @var string
     */
    public $classId;

    /**
     * @example 二年级1班
     *
     * @var string
     */
    public $className;

    /**
     * @var process[]
     */
    public $process;
    protected $_name = [
        'cardBizId' => 'cardBizId',
        'cardBizName' => 'cardBizName',
        'classId' => 'classId',
        'className' => 'className',
        'process' => 'process',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->cardBizId) {
            $res['cardBizId'] = $this->cardBizId;
        }
        if (null !== $this->cardBizName) {
            $res['cardBizName'] = $this->cardBizName;
        }
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->className) {
            $res['className'] = $this->className;
        }
        if (null !== $this->process) {
            $res['process'] = [];
            if (null !== $this->process && \is_array($this->process)) {
                $n = 0;
                foreach ($this->process as $item) {
                    $res['process'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return classStatistics
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardBizId'])) {
            $model->cardBizId = $map['cardBizId'];
        }
        if (isset($map['cardBizName'])) {
            $model->cardBizName = $map['cardBizName'];
        }
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['className'])) {
            $model->className = $map['className'];
        }
        if (isset($map['process'])) {
            if (!empty($map['process'])) {
                $model->process = [];
                $n = 0;
                foreach ($map['process'] as $item) {
                    $model->process[$n++] = null !== $item ? process::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
